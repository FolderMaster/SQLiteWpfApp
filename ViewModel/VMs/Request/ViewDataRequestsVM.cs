﻿using ViewModel.Enums;
using ViewModel.Interfaces;

namespace ViewModel.VMs.Request
{
    public class ViewDataRequestsVM : ViewRequestsVM
    {
        private TableName _tableName;

        public TableName TableName
        {
            get => _tableName;
            set
            {
                if (SetProperty(ref _tableName, value))
                {
                    ExecuteSqlCommand(CreateSelectCommand("*", $"{TableName}"));
                }
            }
        }

        public ViewDataRequestsVM(IDbContextBuilder dataBaseContextCreator,
            IResourceService resourceService, IMessageService messageService) :
            base(dataBaseContextCreator, resourceService, messageService) { }
    }
}