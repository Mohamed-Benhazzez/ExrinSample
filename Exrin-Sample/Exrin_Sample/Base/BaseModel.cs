namespace ExrinSample.Base
{
    using Exrin.Abstraction;

    public class BaseModel : Exrin.Framework.Model
    {
        public BaseModel(IExrinContainer exrinContainer, IModelState modelState)
            : base(exrinContainer, modelState)
        {
        }
    }
}
