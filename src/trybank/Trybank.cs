namespace Trybank.Lib
{
    public class TrybankLib
    {
        public bool Logged;
        public int loggedUser;

        //0 -> Número da conta
        //1 -> Agência
        //2 -> Senha
        //3 -> Saldo
        public int[,] Bank;
        public int registeredAccounts;
        private int maxAccounts = 50;

        public TrybankLib()
        {
            loggedUser = -99;
            registeredAccounts = 0;
            Logged = false;
            Bank = new int[maxAccounts, 4];
        }

        // 1. Construa a funcionalidade de cadastrar novas contas
        public void RegisterAccount(int number, int agency, int pass)
        {
            // Verificar se a conta já existe no array Bank
            for (int i = 0; i < registeredAccounts; i++)
            {
                if (Bank[i, 0] == number && Bank[i, 1] == agency)
                {
                    throw new ArgumentException("A conta já está sendo usada!");
                }
            }

            // Se a conta não existir, armazenar a nova conta com saldo 0
            Bank[registeredAccounts, 0] = number;  // Número da conta
            Bank[registeredAccounts, 1] = agency;  // Agência
            Bank[registeredAccounts, 2] = pass;    // Senha
            Bank[registeredAccounts, 3] = 0;       // Saldo inicial

            // Incrementar o número de contas registradas
            registeredAccounts++;
        }

        // 2. Construa a funcionalidade de fazer Login
        public void Login(int number, int agency, int pass)
        {
            // Verificar se já existe um usuário logado
            if (Logged)
            {
                throw new AccessViolationException("Usuário já está logado");
            }

            // Procurar a combinação de número e agência no array Bank
            bool accountFound = false;
            for (int i = 0; i < registeredAccounts; i++)
            {
                // Verifica se o número da conta e a agência correspondem
                if (Bank[i, 0] == number && Bank[i, 1] == agency)
                {
                    accountFound = true;

                    // Verifica se a senha está correta
                    if (Bank[i, 2] == pass)
                    {
                        // Atualiza o estado de logado e armazena a posição do usuário
                        Logged = true;
                        loggedUser = i;
                        return; // Login bem-sucedido, não precisa continuar
                    }
                    else
                    {
                        // Senha incorreta
                        throw new ArgumentException("Senha incorreta");
                    }
                }
            }

            // Se não encontrar a combinação de número e agência, lança exceção
            if (!accountFound)
            {
                throw new ArgumentException("Agência + Conta não encontrada");
            }
        }

        // 3. Construa a funcionalidade de fazer Logout
        public void Logout()
        {
            // Verifica se há algum usuário logado
            if (!Logged)
            {
                throw new AccessViolationException("Usuário não está logado");
            }

            // Caso haja um usuário logado, altera o estado e reseta o índice loggedUser
            Logged = false;
            loggedUser = -99;
        }

        // 4. Construa a funcionalidade de checar o saldo
        public int CheckBalance()
        {
            throw new NotImplementedException();
        }

        // 5. Construa a funcionalidade de depositar dinheiro
        public void Deposit(int value)
        {
            throw new NotImplementedException();
        }

        // 6. Construa a funcionalidade de sacar dinheiro
        public void Withdraw(int value)
        {
            throw new NotImplementedException();
        }

        // 7. Construa a funcionalidade de transferir dinheiro entre contas
        public void Transfer(int destinationNumber, int destinationAgency, int value)
        {
            throw new NotImplementedException();
        }
    }
}
