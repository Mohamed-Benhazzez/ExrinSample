namespace ExrinSample.Model
{
    using Abstraction.Model;
    using Abstraction.ModelState;
    using Base;
    using Exrin.Abstraction;
    using System.Threading.Tasks;

    public class AuthModel : BaseModel, IAuthModel
    {
        public AuthModel(IExrinContainer exrinContainer) 
            : base(exrinContainer, new AuthModelState()) {}

        public Task<bool> Login()
        {
            return Task.FromResult(true);
        }
    }
}
