namespace POO_INTERFACE.classes
{
    public interface ICarrinho
    {
         //CRUD

         //CREATE = CRIAR
        void Cadastrar(Produto produto);

         //READ = LER
        void Listar();

         //UPDATE = ATUALIZAR
        void Alterar(int cod , Produto produto);

         //DELETE = DELETAR
         void Deletar(int codigo);


    }
}