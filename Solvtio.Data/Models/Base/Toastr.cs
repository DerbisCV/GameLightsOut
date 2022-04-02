using System;
using System.Collections.Generic;

namespace Solvtio.Models
{
    [Serializable]
    public class Toastr
    {
        #region Constructors
        public Toastr()
        {
            ToastMessages = new List<ToastMessage>();
            ShowNewestOnTop = false;
            ShowCloseButton = true;
        }
        #endregion

        #region Properties
        public bool ShowNewestOnTop { get; set; }
        public bool ShowCloseButton { get; set; }
        public List<ToastMessage> ToastMessages { get; set; }
        #endregion

        #region Methods
        public ToastMessage AddToastMessage(string title, string message, ToastType toastType)
        {
            var toast = new ToastMessage()
            {
                Title = title,
                Message = message,
                ToastType = toastType
            };
            ToastMessages.Add(toast);
            return toast;
        }

        public ToastMessage AddToastMessageSuccess(string message)
        {
            var toastMessage = new ToastMessage()
            {
                Message = message,
                ToastType = ToastType.Success
            };
            ToastMessages.Add(toastMessage);
            return toastMessage;
        }
        #endregion
    }

    [Serializable]
    public class ToastMessage
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public ToastType ToastType { get; set; }
        public bool IsSticky { get; set; }
    }

}
