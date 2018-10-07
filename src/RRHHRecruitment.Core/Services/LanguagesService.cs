using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace RRHHRecruitment.Core.Services
{
    public sealed  class LanguagesService
    {
        private readonly ILanguagesRepository _languagesRepository;

        public LanguagesService(ILanguagesRepository languagesRepository)
        {
            _languagesRepository = languagesRepository;
        }

        public IEnumerable<Language> GetLanguages(int userId) 
            => _languagesRepository.FindAll(language => language.IsActive && language.UserId == userId).ToList();

        public IOperationResult<Language> CreateLanguage(Language language)
        {
            if (string.IsNullOrWhiteSpace(language.Name) )
            {
                return BasicOperationResult<Language>.Fail(
                    "Se necesita por lo menos el nombre para poder guardar un idioma");
            }

            return _languagesRepository.Create(language);
        }
    }
}
