using System;

namespace MeuTwitter.Infra
{
    public static class DateTimeParser
    {
        public static string TryParse(DateTime dataCriacao)
        {
            var mensagemDias = string.Empty;
            var mensagemHoras = string.Empty;
            var mensagemMinutos = string.Empty;
            var dateTimeNow = DateTime.Now;

            if (dataCriacao > dateTimeNow)
                throw new ArgumentOutOfRangeException();

            var diffTime = dateTimeNow - dataCriacao;

            if (diffTime.Days > 0)
            {
                mensagemDias = diffTime.Days == 1 ? $"{diffTime.Days} dia" : $"{diffTime.Days} dias";
            }

            if (diffTime.Hours > 0)
            {
                mensagemHoras = diffTime.Hours == 1 ? $"{diffTime.Hours} hora" : $"{diffTime.Hours} horas";
            }

            if (diffTime.Minutes > 0)
            {
                mensagemMinutos = diffTime.Minutes == 1
                    ? $"{diffTime.Minutes} minuto"
                    : $"{diffTime.Minutes} minutos";
            }

            var mensagemFinal = string.Empty;

            if (!string.IsNullOrWhiteSpace(mensagemDias))
            {
                mensagemFinal += mensagemDias;

                if (!string.IsNullOrWhiteSpace(mensagemHoras) || !string.IsNullOrWhiteSpace(mensagemMinutos))
                    mensagemFinal += ", ";
            }

            if (!string.IsNullOrWhiteSpace(mensagemHoras))
            {
                mensagemFinal += mensagemHoras;

                if (!string.IsNullOrWhiteSpace(mensagemMinutos))
                    mensagemFinal += ", ";
            }

            if (!string.IsNullOrWhiteSpace(mensagemMinutos))
            {
                mensagemFinal += mensagemMinutos;
            }

            return $"{mensagemFinal.Trim()} atrás";
        }
    }
}