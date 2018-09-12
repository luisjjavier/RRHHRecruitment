using RRHHRecruitment.Core.Contracts;
using RRHHRecruitment.Core.Contracts.Repositories;
using RRHHRecruitment.Core.Models;
using System;
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

        public IEnumerable<Language> GetLanguages() 
            => _languagesRepository.Get().ToList();

        public IOperationResult<Language> CreateLanguage(Language language)
        {
            return _languagesRepository.Create(language);
        }
    }
}
