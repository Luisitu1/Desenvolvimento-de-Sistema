using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
namespace BLL
{
    public class FornecedorBLL
    {
        public void Inserir(Fornecedor _fornecedor)
        {
            new FornecedorDAL().Inserir(_fornecedor);
        } //pronto

        //---------------------------------------------------------------------------------------------------------------------

        public Fornecedor BuscarPorId(int _id)
        {
            return new FornecedorDAL().BuscarPorId(_id);
        } //pronto

        //---------------------------------------------------------------------------------------------------------------------

        public List<Fornecedor> BuscarPorNome(string _nome)
        {
            return new FornecedorDAL().BuscarPorNome(_nome);
        } //pronto

        //---------------------------------------------------------------------------------------------------------------------

        public List<Fornecedor> BuscarPorTodos()
        {
            return new FornecedorDAL().BuscarPorTodos();
        } //pronto

        //---------------------------------------------------------------------------------------------------------------------

        public List<Fornecedor> BuscarSite(string _site)
        {
            return new FornecedorDAL().BuscarSite(_site);
        } //pronto

        //---------------------------------------------------------------------------------------------------------------------

        public void Alterar(Fornecedor _fornecedor)
        {
            new FornecedorDAL().Alterar(_fornecedor);
        } //pronto

        //---------------------------------------------------------------------------------------------------------------------

        public void Excluir(int _id)
        {
            new FornecedorDAL().Excluir(_id);
        } //pronto


    }
}
