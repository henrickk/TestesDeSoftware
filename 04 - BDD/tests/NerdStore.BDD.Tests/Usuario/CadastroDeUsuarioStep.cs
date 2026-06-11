using System;
using Reqnroll;

namespace NerdStore.BDD.Tests.Usuario
{
    [Binding]
    public class CadastroDeUsuarioStep
    {


        [When("Ele clicar em registrar")]
        public void WhenEleClicarEmRegistrar()
        {
            throw new PendingStepException();
        }

        [When("Preencher os dados do formulario")]
        public void WhenPreencherOsDadosDoFormulario(DataTable dataTable)
        {
            throw new PendingStepException();
        }

        [When("Clincar no botão registrar")]
        public void WhenClincarNoBotaoRegistrar()
        {
            throw new PendingStepException();
        }





        [When("Preencher os dados do formulario com uma senha sem maiusculas")]
        public void WhenPreencherOsDadosDoFormularioComUmaSenhaSemMaiusculas(DataTable dataTable)
        {
            throw new PendingStepException();
        }

        [Then("Ele receberá uma mensagem de erro que a senha precisa conter uma letra maiuscula")]
        public void ThenEleReceberaUmaMensagemDeErroQueASenhaPrecisaConterUmaLetraMaiuscula()
        {
            throw new PendingStepException();
        }

        [When("Preencher os dados do formulario com uma senha sem caractere especial")]
        public void WhenPreencherOsDadosDoFormularioComUmaSenhaSemCaractereEspecial(DataTable dataTable)
        {
            throw new PendingStepException();
        }

        [Then("Ele receberá uma mensagem de erro que a senha precisa conter um caractere especial")]
        public void ThenEleReceberaUmaMensagemDeErroQueASenhaPrecisaConterUmCaractereEspecial()
        {
            throw new PendingStepException();
        }

    }
}
