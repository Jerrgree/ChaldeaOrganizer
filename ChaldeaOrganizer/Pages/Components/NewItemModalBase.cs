using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace ChaldeaOrganizer.Pages.Components
{
    public abstract class NewItemModalBase<T> : ComponentBase
    {
        [Parameter]
        public bool IsOpen { get; set; }

        [Parameter]
        public EventCallback CloseModal { get; set; }

        [Parameter]
        public EventCallback<T> AddItem { get; set; }

        protected string ModalClass => IsOpen ? "show" : "";

        protected virtual async Task Cancel()
        {
            Reset();

            await CloseModal.InvokeAsync(null);
        }

        protected abstract bool CannotAddItem { get; }

        protected virtual async Task OnAddItem()
        {
            await AddItem.InvokeAsync(BuildNewItem());

            Reset();
        }

        protected abstract void Reset();

        protected abstract T BuildNewItem();
    }
}