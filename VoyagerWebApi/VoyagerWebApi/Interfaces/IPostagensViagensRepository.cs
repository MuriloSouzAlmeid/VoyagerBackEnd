﻿using VoyagerWebApi.Domains;
using VoyagerWebApi.ViewModels;

namespace VoyagerWebApi.Interfaces
{
    public interface IPostagensViagensRepository
    {
        void Cadastrar(PostagensViagens novaPostagem);

        void Deletar(Guid IdPostagemViagem);

        void Atualizar(Guid IdPostagemViagem, CadastrarPostagemViewModel dadosAtualizados);

        PostagensViagens BuscarPorId(Guid IdPostagemViagem);

        List<PostagensViagens> ListarPorPostCurtidoEPostado(Guid idUsuario);
    }
}
