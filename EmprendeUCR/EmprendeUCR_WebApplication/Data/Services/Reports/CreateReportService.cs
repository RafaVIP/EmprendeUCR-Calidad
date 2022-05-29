using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmprendeUCR_WebApplication.Data.Entities;
using Syncfusion.Blazor.TreeGrid;

namespace EmprendeUCR_WebApplication.Data.Services.Reports
{
    public class CreateReportService : PageModel
    {
        public CreateReportService(Contexts.SqlServerDbContext context)
        {
            _context = context;
        }
        /*
         * 
         * Private Variables
         * 
         * 
         */
        private readonly Contexts.SqlServerDbContext _context;
        /*
         * 
         * Private Variables
         * 
         */
        private bool TitleNotValid;
        public bool AddDialogVisible;
        public string Title;
        public string Content;
        public bool CreateReportDisabled;

        /**
         * @brief Open a Popup with the form to add a category name
         * @details the dialog was made with a SfDialog with HTML
         * @param
         * @return
         */
        public void OpenCreateReportDialog()
        {
            this.AddDialogVisible = true;
        }


        /**
        * @brief Closes the Popup that allows the adding of a new category
        * @details The dialog was made with a SfDialog with HTML
        * @param 
        * @return
        */
        public void CloseCreateReportDialog()
        {
            this.AddDialogVisible = false;
            ResetCreateReportData();
        }

        /**
        * @brief Adds a new category to the database and reflects the changes to the site
        * @details calls the service InsertCategoryAsync(Category); to add the category, and getParentId(TitleDad) to get its parent, add category only if the category values are valid
        * @param 
        * @return 
        */
        public async void CreateReport()
        {
            this.AddDialogVisible = false;
            Report report = new Report();
            report.Title = Title;
            report.Content = Content;
            await InsertReportAsync(report);
            ResetCreateReportData();
        }

        /**
        * @brief Resets all local variables used for adding categories, to their initial state
        * @details all the variables that were set bellow are used for adding categories
        * @param
        * @return
        */
        public void ResetCreateReportData()
        {
            AddDialogVisible = false ;
            Title = null ;
            Content = null ;
            CreateReportDisabled = false ;
            TitleNotValid = false;
    }

        /**
        * @brief Inserts a new category in the databased
        * @param Category of type category, that will be inserted in the database
        * @return Task<bool>, depends if the action could be made
        */
        public async Task<bool> InsertReportAsync(Report report)
        {
            await _context.Report.AddAsync(report);
            await _context.SaveChangesAsync();
            return true;
        }
        public void ValidateTitle(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            TitleNotValid = true;
            Title = (String)args.Value;
            if (Title.Length > 0)
            {
                TitleNotValid = false;
            }
            CreateReportDisabled = TitleNotValid;
        }

        //Refresh Interface
    }
}
