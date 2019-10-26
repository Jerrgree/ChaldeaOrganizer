using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChaldeaOrganizer.Pages.Components
{
    public abstract class NewItemModalBase : ComponentBase
    {
        [Parameter]
        public bool IsOpen { get; set; }

        [Parameter]
        public Action CloseModal { get; set; }

        protected string ModalClass => IsOpen ? "show" : "";

        protected abstract bool CannotAddItem { get; }
    }
}