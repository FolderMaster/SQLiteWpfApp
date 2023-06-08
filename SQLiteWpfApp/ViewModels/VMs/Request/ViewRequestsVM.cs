﻿using SQLiteWpfApp.ViewModels.Services;

namespace SQLiteWpfApp.ViewModels.VMs.Request
{
    public class ViewRequestsVM : RequestsVM
    {
        protected string CreateSelectCommand(string selectContent, string fromContent,
            string whereContent = "", string groupByContent = "", string havingContent = "",
            string orderByContent = "") =>
            $"SELECT {selectContent} " +
            $"FROM {fromContent}" +
            (string.IsNullOrEmpty(whereContent) ? "" : $" WHERE {whereContent}") +
            (string.IsNullOrEmpty(groupByContent) ? "" : $" GROUP BY {groupByContent}") +
            (string.IsNullOrEmpty(havingContent) ? "" : $" HAVING {havingContent}") +
            (string.IsNullOrEmpty(orderByContent) ? "" : $" ORDER BY {orderByContent}");

        public ViewRequestsVM(IMessageService messageService) : base(messageService) { }
    }
}