namespace BE.Unity.Shared.Mvvmc
{
    /// <summary>
    /// Represents a view that can bind to a view model.
    /// </summary>
    /// <typeparam name="TViewModel">The view model type consumed by the view.</typeparam>
    public interface IView<in TViewModel>
    {
        /// <summary>
        /// Binds the view to its current view model.
        /// </summary>
        /// <param name="viewModel">The view model to display.</param>
        void Bind(TViewModel viewModel);
    }
}

