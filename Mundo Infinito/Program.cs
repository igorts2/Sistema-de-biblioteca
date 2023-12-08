using Mundo_Infinito.Menus;



while (true)
{
    Console.Clear();
    ExibirLogo();
    OpcoesDoMenu();
    Menu.OpcaoEscolhida();

    Console.WriteLine("Deseja voltar ao menu principal? (S/N)");
    string resposta = Console.ReadLine()?.Trim().ToUpper();

    if (resposta != "S")
    {
        break; 
    }
}

Console.WriteLine("Obrigado por usar nosso sistema. Até mais!");


void ExibirLogo()
{
    Console.WriteLine(@"
#     #                                ###                                       
##   ## #    # #    # #####   ####      #  #    # ###### # #    # # #####  ####  
# # # # #    # ##   # #    # #    #     #  ##   # #      # ##   # #   #   #    # 
#  #  # #    # # #  # #    # #    #     #  # #  # #####  # # #  # #   #   #    # 
#     # #    # #  # # #    # #    #     #  #  # # #      # #  # # #   #   #    # 
#     # #    # #   ## #    # #    #     #  #   ## #      # #   ## #   #   #    # 
#     #  ####  #    # #####   ####     ### #    # #      # #    # #   #    ####  
                                                                                 ");
}

void OpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para Ver os livros disponiveis!");
    Console.WriteLine("Digite 2 para ver os os autores disponiveis!");
    Console.WriteLine("Digite 3 para pesquisar um livro!");
    Console.WriteLine("Digite 4 para emprestimos e devolução!");
    Console.WriteLine("Digite 5 para Sair!");
    Console.WriteLine("Digite 0 para Opções avançadas!\n");
    
}

