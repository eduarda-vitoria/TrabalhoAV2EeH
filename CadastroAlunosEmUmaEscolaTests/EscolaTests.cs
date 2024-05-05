using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrabalhoAV2EeH
{

    [TestClass]
    public class EscolaTest
    {
        [TestMethod]
        public void AdicionarAlunoTest()
        {
            Escola escola = new Escola();
            Aluno aluno = new Aluno("João", 15);

            escola.AdicionarAluno(aluno);

            Assert.IsTrue(escola.BuscarAlunoPorNome("João") != null);
        }

        [TestMethod]
        public void RemoverAlunoTest()
        {
            Escola escola = new Escola();
            Aluno aluno = new Aluno("Maria", 16);

            escola.AdicionarAluno(aluno);
            escola.RemoverAluno(aluno);

            Assert.IsTrue(escola.BuscarAlunoPorNome("Maria") == null);
        }
    }
}