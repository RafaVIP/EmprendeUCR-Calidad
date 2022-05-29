using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using EmprendeUCR.Domain.PaymentInfos.Entities;
using System.Collections.Generic;
using System;

namespace EmprendeUCR.Presentation.Pages.PaymentInfos
{
    public class SinpeIbanPaymentInfoEntrepreneurBase : ComponentBase
    {
        protected string AddButtonTitle = "Agregar";
        protected const string SINPE_IBAN = "SINPE IBAN";
        protected SfGrid<SinpeIbanPaymentInfo> SinpeIbanPaymentInfoGrid;
        protected IEnumerable<SinpeIbanPaymentInfo> _sinpeIbanPaymentInfoList;
        protected List<ItemModel> SinpeIbanToolbarItems = new List<ItemModel>();
        protected bool AddSinpeIbanDialogVisible = false;
        protected string AddedSinpeIban = "";

        public void SinpeIbanCommandClicked(CommandClickEventArgs<SinpeIbanPaymentInfo> args)
        {
            if (args.CommandColumn.Title == "Editar")
            {
            }
            else if (args.CommandColumn.Title == "Eliminar")
            {
            }
        }

        protected void SinpeIbanToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            if (args.Item.Text == AddButtonTitle)
            {
                ShowAddSinpeIbanDialog();
            }
        }

        protected void ShowAddSinpeIbanDialog()
        {
            AddSinpeIbanDialogVisible = true;
        }

        protected void CloseAddSinpeIbanDialog()
        {
            AddedSinpeIban = "";
            AddSinpeIbanDialogVisible = false;
        }
    }
}