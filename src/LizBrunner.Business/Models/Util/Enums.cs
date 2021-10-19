using System.ComponentModel.DataAnnotations;

namespace LizBrunner.Business.Models.Util
{
   
        public enum Genders
        {

            [Display(Name = "Prefiro não informar")]
            PrefiroNaoInformar,
            Masculino,
            Feminino
        }


        public enum States
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
            TO,
            Internacional
        }
       

   
}
