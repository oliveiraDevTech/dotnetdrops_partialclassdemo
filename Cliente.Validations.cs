
namespace PartialClassDemo
{
    public partial class Cliente
    {
        public bool EmailValido()
        {
            return Email?.Contains("@") == true;
        }
    }
}
