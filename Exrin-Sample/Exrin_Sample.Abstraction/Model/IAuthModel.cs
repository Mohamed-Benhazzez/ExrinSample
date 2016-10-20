namespace ExrinSample.Abstraction.Model
{
    using Exrin.Abstraction;
    using System.Threading.Tasks;

    public interface IAuthModel: IBaseModel
    {
        Task<bool> Login();
    }
}
