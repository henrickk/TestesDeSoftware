using System;
using Reqnroll;

namespace NerdStore.BDD.Tests.Usuario
{
    [Binding]
    public class LoginDeUsuarioStep
    {
        [When("Ele clicar em login")]
        public void WhenEleClicarEmLogin()
        {
            throw new PendingStepException();
        }

        [When("Preencher os dados do formulário de login")]
        public void WhenPreencherOsDadosDoFormularioDeLogin(DataTable dataTable)
        {
            throw new PendingStepException();
        }

        [When("Clicar no botão login")]
        public void WhenClicarNoBotaoLogin()
        {
            throw new PendingStepException();
        }

    }
}
