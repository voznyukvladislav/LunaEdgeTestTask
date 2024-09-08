using LunaEdgeTestTask.Constants.Errors;
using LunaEdgeTestTask.Constants.Success;
using LunaEdgeTestTask.Data;
using LunaEdgeTestTask.DTOs;
using LunaEdgeTestTask.Interfaces;

namespace LunaEdgeTestTask.Services
{
    public class AuthService
    {
        private readonly IRepository _repository;
        private readonly IConfiguration _configuration;
        public AuthService(IRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        public void Registration(RegistrationDTO registrationDTO, out string message)
        {
            if (!Validator.ValidateUsername(_repository, registrationDTO.Username))
            {
                message = UserErrors.INVALID_USERNAME;
                return;
            }
            if (!Validator.ValidateEmail(registrationDTO.Email))
            {
                message = UserErrors.INVALID_EMAIL;
                return;
            }
            if (!Validator.ValidatePassword(registrationDTO.Password))
            {
                message = UserErrors.INVALID_PASSWORD;
                return;
            }


            message = UserSuccess.REGISTRATED;
        }
    }
}
