﻿using System;


namespace Series
{
    public class Serie : EntidadeBase
    {
        //atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        //métodos

        public Serie(int id, Genero genero, string titulo,
            string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = titulo;
            this.Ano = ano;
            this.Excluido = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;//faz funcionar em todos sistemas operacionais
            retorno += "Título : " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += " Excluido " + this.Excluido + Environment.NewLine;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}