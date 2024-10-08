﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Abstractions
{
    public class Result
    {
        protected internal Result(bool isSuccess, Error error)
        {
            if(isSuccess && error != Error.None)
            {
                throw new ArgumentException("success cant have error");
            }

            if(isSuccess == false && error == Error.None)
            {
                throw new ArgumentException("failure should have error object");
            }

            IsSuccess = isSuccess;
            Error = error;  
            
        }

        public bool IsSuccess { get;  }
        public bool IsFailure => !IsSuccess;
        public Error Error { get;  }

        public static Result Success() => new(true, Error.None);
        public static Result Failure(Error error) => new(false, error);

        public static Result<TValue> Success<TValue>(TValue value) => new(value, true, Error.None);

        public static Result<TValue> Failure<TValue>(Error error) => new(default, false ,error);

        public static Result<TValue> Create<TValue>(TValue? value)
        {
            if(value != null)
            {   
                return Success(value);
            }
            else
            {
                return Failure<TValue>(Error.NullValue); 
            }
        }


    };

    public class Result<TValue> : Result
    {
        private readonly TValue? _value;
        protected internal Result(TValue? value, bool isSuccess, Error error) : 
            base(isSuccess, error)
        {
            _value = value;
        }

        public TValue Value => IsSuccess
            ? _value!
            : throw new InvalidOperationException("The value of failure result can not be accessed");


        public static implicit operator Result<TValue> (TValue? value) => Create<TValue>(value);
    }
}
