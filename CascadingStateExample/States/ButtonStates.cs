using Microsoft.AspNetCore.Components;
using System;

namespace CascadingStateExample.States
{
    public class ButtonStates
    {
        /// <summary>
        /// Button visibility 
        /// </summary>
        public bool Visible
        {
            get => _visible; 
            set
            {
                // only trigger if value changes
                if(value != _visible)
                {
                    // change visibility and raise event
                    _visible = value;
                    OnVisibilityChanged?.Invoke(_visible);
                }
            }
        }

        /// <summary>
        /// field
        /// </summary>
        private bool _visible = false;

        /// <summary>
        /// Event raised when visibility changes - this allows components to rerender via StateHasChanged()
        /// </summary>
        public event Action<bool> OnVisibilityChanged;

        /// <summary>
        /// Event raised when Save button is clicked
        /// </summary>
        public event Action<string> OnSaved;

        /// <summary>
        /// Event raised when Cancel button is clicked
        /// </summary>
        public event Action<string> OnCancelled;

        /// <summary>
        /// Raise save event
        /// </summary>
        /// <param name="msg"></param>
        public void Save(string msg) => OnSaved?.Invoke(msg);
        
        /// <summary>
        /// Raise cancel event
        /// </summary>
        /// <param name="msg"></param>
        public void Cancel(string msg) => OnSaved?.Invoke(msg);

    }
}
