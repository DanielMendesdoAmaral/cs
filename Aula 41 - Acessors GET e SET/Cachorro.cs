namespace Aula_41___Acessors_GET_e_SET
{
    public class Cachorro
    {
        private string cor;

        public string c {
            get {
                return cor;
            }
            set {
                cor=value; //O valor atribuído ao objeto fica armazenado em value.
            }
        }
    }
}