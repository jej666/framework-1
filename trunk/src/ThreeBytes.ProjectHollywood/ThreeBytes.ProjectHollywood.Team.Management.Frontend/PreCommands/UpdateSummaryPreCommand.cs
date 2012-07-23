﻿using System;
using FluentValidation.Results;
using NServiceBus;
using SignalR;
using ThreeBytes.Core.Commands.Abstract;
using ThreeBytes.ProjectHollywood.Team.Management.Entities;
using ThreeBytes.ProjectHollywood.Team.Management.Frontend.Hubs;
using ThreeBytes.ProjectHollywood.Team.Management.Service.Abstract;
using ThreeBytes.ProjectHollywood.Team.Management.Validations.Abstract;
using ThreeBytes.ProjectHollywood.Team.Messages.Commands;

namespace ThreeBytes.ProjectHollywood.Team.Management.Frontend.PreCommands
{
    public class UpdateSummaryPreCommand : ICommand
    {
        public IBus Bus { get; set; }
        public IConnectionManager ConnectionManager;
        public ValidationResult Results { get; set; }

        public Guid Id { get; set; }
        public string NewSummary { get; set; }
        public string UpdatedBy { get; set; }

        private readonly ITeamManagementEmployeeService service;
        private readonly ITeamManagementEmployeeValidatorResolver validatorResolver;
        private bool executed;

        public UpdateSummaryPreCommand(IConnectionManager connectionManager, ITeamManagementEmployeeValidatorResolver validatorResolver, ITeamManagementEmployeeService service)
        {
            if (service == null)
                throw new ArgumentNullException("service");

            if (validatorResolver == null)
                throw new ArgumentNullException("validatorResolver");

            ConnectionManager = connectionManager;

            this.validatorResolver = validatorResolver;
            this.service = service;
        }

        public void Execute()
        {
            Validate();

            executed = true;

            if (Results.IsValid)
            {
                Bus.Send<IUpdateTeamEmployeeSummaryCommandMessage>(x => { x.Id = Id; x.NewSummary = NewSummary; x.UpdatedBy = UpdatedBy; });
                ConnectionManager.GetClients<TeamManagementHub>().handleUpdatedTeamEmployeeSummaryEventMessage(Id, NewSummary);
            }
        }

        public void Validate()
        {
            TeamManagementEmployee employee = service.GetById(Id);

            if (employee != null)
            {
                employee.Summary = NewSummary;
                employee.LastModifiedBy = UpdatedBy;
            }

            Results = validatorResolver.UpdateSummaryValidator().Validate(employee);
        }

        public bool HasExecuted { get { return executed; } }
    }
}