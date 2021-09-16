using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo dados - Fundamentos", LendoDados.Executar },
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternários - Fundamentos", OperadoresTernarios.Executar },

                //Estrutura De Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIF.Executar},
                {"Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else If - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura SWITCH - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura WHILE - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura DO WHILE - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura FOR - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura FOREACH - Estrutura de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar},

                //Classes e Métodos
                { "Membros - Classes e Métodos", Membros.Executar},
                { "Construtores - Classes e Métodos", Construtores.Executar},
                { "Metodos com retorno - Classes e Métodos", MetodosComRetorno.Executar},
                { "Metodos estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                { "Atributos estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                { "Desafio atributo - Classes e Métodos", DesafioAtributo.Executar},
                { "Params - Classes e Métodos", Params.Executar},
                { "Parametros nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                { "Getters & Setters - Classes e Métodos", GetSet.Executar},
                { "Props - Classes e Métodos", Props.Executar},
                { "Atributos ReadOnly - Classes e Métodos", ReadOnly.Executar},
                { "Enumerações - Classes e Métodos", ExemploEnum.Executar},
                { "Struct - Classes e Métodos", ExemploStruct.Executar},
                { "StructVSClass (diferenças) - Classes e Métodos", StructVSClass.Chama},
                { "Valor vs Referência - Classes e Métodos", ValorVSReferencia.Executar},
                { "Ref vs Out - Classes e Métodos", RefVSOut.Executar},
                { "Parametro padrão - Classes e Métodos", ParametroPadrao.Executar},

                // Coleções
                { "Array - Coleções", Colecoes.Array.Executar},
                { "ColeçõesList - Coleções", ColecoesList.Executar},
                { "ArrayList (lista de array) - Coleções", ExemploArrayList.Executar},
                { "Coleções set - Coleções", ColecoesSet.Executar},
                { "Coleções Queue - Coleções", ColecoesQueue.Executar},
                { "Igualdade - Coleções", Igualdade.Executar},
                { "Stack - Coleções", ColecoesStack.Executar},
                { "Coleções dictionary - Coleções", ColecoesDictionary.Executar},

                //OO
                { "Herança - Orientação a Objetos", Heranca.Executar},
                { "Construtor this - Orientação a Objetos", ConstrutorThis.Executar},
                
                //Tópicos avançados
                { "Nullables - Tópicos avançados", Nullables.Executar},
                { "Dynamics - Tópicos avançados", Dynamics.Executar},
                { "Genericos - Tópicos avançados", Genericos.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}