using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ReservasCoworking.Api.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // 1. Descobre qual foi o erro
            var exception = context.Exception;

            // 2. Define o status HTTP (ex: 400 para erros de validação, 500 para erro interno do servidor)
            // Se você tiver criado uma exceção personalizada para as regras de negócio, pode checar aqui.
            int statusCode = exception is ArgumentException ? 400 : 500;

            // 3. Monta um objeto de erro padronizado (Problem Details)
            var problemDetails = new ProblemDetails
            {
                Status = statusCode,
                Title = "Ocorreu um erro ao processar sua requisição.",
                Detail = exception.Message // Retorna a mensagem do erro
            };

            // 4. Substitui a resposta quebrada por esse JSON bonitinho
            context.Result = new ObjectResult(problemDetails)
            {
                StatusCode = statusCode
            };

            // 5. Avisa o .NET: "Pode deixar, eu já cuidei desse erro!"
            context.ExceptionHandled = true;
        }
    }
}
