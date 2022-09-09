using System;
using System.Collections.Generic;
using System.Text;

namespace Coban.SharedLibrary.DTO
{
    public class ErrorDTO
    {
        public ErrorDTO()
        {
            Errors = new List<string>();
        }
        public ErrorDTO(string error, bool isShow)
        {
            Errors.Add(error);
            isShow = true;
        }
        public ErrorDTO(List<string> errors, bool isShow)
        {
            Errors = errors;
            IsShow = isShow;

        }
        public List<string> Errors { get; private set; }
        public bool IsShow { get; private set; }
    }
}
