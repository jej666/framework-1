﻿ALTER TABLE [dbo].[EmailTemplateManagementTemplate]
    ADD CONSTRAINT [PK_EmailTemplateManagementTemplate] PRIMARY KEY CLUSTERED ([TemplateId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
