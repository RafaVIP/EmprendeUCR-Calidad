using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using EmprendeUCR.Domain.PaymentInfos.Entities;
using System.Collections.Generic;
using System;

namespace EmprendeUCR.Presentation.Pages.PaymentInfos
{
    public class CardPaymentInfoEntrepreneurBase : ComponentBase
    {
        protected string AddButtonTitle = "Agregar";
        protected const string CARD = "Visa";
        // CARD

        protected SfGrid<CardPaymentInfo> CardPaymentInfoGrid;
        protected IEnumerable<CardPaymentInfo> _cardPaymentInfoList;
        protected List<ItemModel> CardToolbarItems = new List<ItemModel>();
        protected bool AddCardDialogVisible = false;
        protected string AddedCardIban = "";

        public void CardCommandClicked(CommandClickEventArgs<CardPaymentInfo> args)
        {
            if (args.CommandColumn.Title == "Editar")
            {
            }
            else if (args.CommandColumn.Title == "Eliminar")
            {
            }
        }

        protected void CardToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            if (args.Item.Text == AddButtonTitle)
            {
                ShowAddCardIbanDialog();
            }
        }

        protected void ShowAddCardIbanDialog()
        {
            AddCardDialogVisible = true;
        }

        protected void CloseAddCardIbanDialog()
        {
            AddedCardIban = "";
            AddCardDialogVisible = false;
        }
    }
}
