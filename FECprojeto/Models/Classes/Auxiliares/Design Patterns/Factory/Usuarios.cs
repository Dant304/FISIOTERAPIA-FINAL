using CamadaDeDados.Banco;
using FECprojeto.Models.Classes.Auxiliares.Classes_de_persistência;

namespace FECprojeto.Models.Classes.Auxiliares.Design_Patterns.Factory
{
    public class Usuarios
    {
        UsuariosPersistencia up = new UsuariosPersistencia();

        public Fisioterapeuta_Paciente ObterUsuario(string tipo, bool comCelular,fisioterapeuta fis,paciente pac)
        {
            Fisioterapeuta_Paciente user = new Fisioterapeuta_Paciente();

            if (tipo == "fisio")
            {
                if (comCelular == true)
                {
                    user.Fisio = up.FisioterapeutaComCelularClasse(fis);
                }
                else
                {
                    user.Fisio = up.FisioterapeutaSemCelularClasse(fis);
                }
                
            }
            else if (tipo == "pac")
            {
                if (comCelular == true)
                {
                  user.pac = up.PacienteComCelularClasse(pac);
                }
                else
                {
                    user.pac = up.PacienteSemCelularClasse(pac);
                }
            }
            else
            {
                user = null;
            }
            return user;
        }
    }
}