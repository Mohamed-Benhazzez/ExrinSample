namespace ExrinSample.Model
{
    using Abstraction.Model;
    using Base;
    using Exrin.Abstraction;

    public class MainModel : BaseModel, IMainModel
    {
        public MainModel(IExrinContainer exrinContainer)
            : base(exrinContainer, new MainModelState()) { }
    }
}
