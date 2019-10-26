using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChaldeaOrganizer.Pages.Components
{
    public abstract class NewItemModalBase<T> : ComponentBase
    {
        [Parameter]
        public bool IsOpen { get; set; }

        [Parameter]
        public Action CloseModal { get; set; }

        [Parameter]
        public Action<T> AddItem { get; set; }

        protected string ModalClass => IsOpen ? "show" : "";

        protected virtual void Cancel()
        {
            Reset();

            CloseModal?.Invoke();
        }

        protected abstract bool CannotAddItem { get; }

        protected abstract void OnAddItem();

        protected abstract void Reset();
    }
}