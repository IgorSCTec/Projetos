using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadoDeTarefas.Controllers
{
    [Authorize]
    public class BaseController : ControllerBase
    {
    }
}
