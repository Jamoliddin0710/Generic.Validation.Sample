﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorLibrary
{
    public class EntityValidationResult
    {
        public IList<ValidationResult> Errors { get; private set; }
        public bool HasError => Errors.Count > 0;
        public EntityValidationResult(IList<ValidationResult> pErrors = null)
        {
            Errors = pErrors ?? new List<ValidationResult>();
        }
    }

    public class EntityValidator<T> where T : class
    {
        public EntityValidationResult Validate(T entity)
        {
            var validationResults = new List<ValidationResult>();
            var vc = new ValidationContext(entity, null, null);
            Validator.TryValidateObject(entity, vc, validationResults, true);

            return new EntityValidationResult(validationResults);
        }
    }

    public class ValidationHelper
    {
        public static EntityValidationResult ValidateEntity<T>(T entity) where T : class
        {
            return new EntityValidator<T>().Validate(entity);
        }
    }
}
