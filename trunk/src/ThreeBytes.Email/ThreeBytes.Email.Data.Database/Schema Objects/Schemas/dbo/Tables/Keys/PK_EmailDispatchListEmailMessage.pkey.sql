﻿ALTER TABLE [dbo].[EmailDispatchWidgetEmailMessage]
    ADD CONSTRAINT [PK_EmailDispatchWidgetEmailMessage] PRIMARY KEY CLUSTERED ([EmailMessageId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
