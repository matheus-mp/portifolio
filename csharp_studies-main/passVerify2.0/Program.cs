using System;

namespace passVerifies
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining the variables
            bool goodPass = false;
            string? pass = null;

            //Verifies the complexity of the password
            while (goodPass != true)
            {   
                //Verifies if the var password was fully
                while (string.IsNullOrWhiteSpace(pass))
                {  
                    Console.Write("Escreva a sua senha: ");
                    pass = Console.ReadLine();
                }

                //variables with default values in the start of the lace, so that it is not necessary to define the values ​​again.
                bool qttChar = pass.Length >= 8;
                bool upperCase = false;
                bool lowerCase = false;
                bool num = false;
                bool special = false;
                bool noSpace = true;
                
                //A foreach instead a milion of for's, optimize the code
                foreach (char c in pass)
                {
                    if (char.IsUpper(c))
                    {
                        upperCase = true;
                    } else if (char.IsLower(c))
                    {
                        lowerCase = true;
                    } else if (char.IsNumber(c))
                    {
                        num = true;
                    } else if (!char.IsLetterOrDigit(c))
                    {
                        special = true;
                    } 
                    
                    if (char.IsWhiteSpace(c))
                    {
                        noSpace = false;
                    }
                }

                //Verifies if the pass have all the complexity levels
                if (qttChar && upperCase && lowerCase && num && special && noSpace)
                {
                    goodPass = true;
                    Console.WriteLine("Senha forte cadastrada com sucesso!");
                } else
                {
                    //Reveal the errors in the pass and restore the default values
                    if (!qttChar)
                    {
                        Console.WriteLine("Possui menos de 8 caracteres");
                    }
                    if (!upperCase)
                    {
                        Console.WriteLine("Não possui nenhuma letra maiúscula");
                    }
                    if (!lowerCase)
                    {
                        Console.WriteLine("Não possui nenhuma letra minúscula");
                    }
                    if (!num)
                    {
                        Console.WriteLine("Não possui nenhum número");
                    }
                    if (!special)
                    {
                        Console.WriteLine("Não possui nenhum caractere especial");
                    }
                    if (!noSpace)
                    {
                        Console.WriteLine("Possui espaços em branco");
                    }

                    pass = null;

                    
                }
            }
        }
    }
}

//Enunciado:
//
//Peça ao usuário para digitar uma senha.
//
//Valide se a senha atende TODOS os critérios abaixo:
//
//✅ Pelo menos 8 caracteres
//
//✅ Pelo menos 1 letra maiúscula
//
//✅ Pelo menos 1 letra minúscula
//
//✅ Pelo menos 1 número
//
//✅ Pelo menos 1 caractere especial (!@#$%^&*()-_+=)
//
//Se a senha for válida:
//
//Senha forte cadastrada com sucesso!
//
//Caso contrário:
//
//Mostre exatamente quais critérios não foram atendidos.
//
//Exemplo:
//
//A senha não atende aos seguintes critérios:
//- Não possui letra maiúscula
//- Não possui número