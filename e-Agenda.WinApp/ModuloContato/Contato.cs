﻿using e_Agenda.WinApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase<Contato>
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Empresa { get; set; }

        public string Cargo { get; set; }


        public Contato(string nome, string email, string telefone, string empresa, string cargo)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }


        public override void Editar(Contato contato)
        {
            Nome = contato.Nome;
            Email = contato.Email;
            Telefone = contato.Telefone;
            Empresa = contato.Empresa;
            Cargo = contato.Cargo;
        }

        public string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome))
                erros.Add("Preencha o campo nome");

           else if (string.IsNullOrEmpty(Email))
                erros.Add("Preencha o campo e-mail");

            else if (!EmailEhValido(Email))
                erros.Add("E-mail fora do padrão");

            else if (string.IsNullOrEmpty(Telefone))
                erros.Add("Preencha o campo telefone");

            else if (!TelefoneEhValido(Telefone))
                erros.Add("Telefone fora do padrao");

            return erros.ToArray();
        }

        public bool TelefoneEhValido(string telefone)
        {
            string padrao = @"^(?:\([1-9]{2}\)\s?)?(?:9\d{4}-\d{4}|\d{4}-\d{4})$";

            return Regex.IsMatch(telefone, padrao);

        }

        public bool EmailEhValido(string email)
        {
            string padrao = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.(?:com\.br|com)$";

            return Regex.IsMatch(email, padrao);
        }

        public override string ToString()
        {
            return $"Id: {Id} - Nome: {Nome} - Telefone: {Telefone} - Empresa: {Empresa}";
        }
    }
}
