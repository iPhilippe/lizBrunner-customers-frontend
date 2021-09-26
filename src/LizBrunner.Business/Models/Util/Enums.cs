using System.ComponentModel.DataAnnotations;

namespace LizBrunner.Business.Models.Util
{
    public class Enums
    {
        public enum Genders
        {

            Masculino,
            Feminino,
            [Display(Name = "Prefiro não informar")]
            PrefiroNaoInformar
        }


        public enum State
        {
            AC,
            AL,
            AP,
            AM,
            BA,
            CE,
            DF,
            ES,
            GO,
            MA,
            MT,
            MS,
            MG,
            PA,
            PB,
            PR,
            PE,
            PI,
            RJ,
            RN,
            RS,
            RO,
            RR,
            SC,
            SP,
            SE,
            TO
        }
       

    }
}
