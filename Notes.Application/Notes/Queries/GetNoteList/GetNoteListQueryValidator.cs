using FluentValidation;
using System;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class GetNoteListQueryValidator : AbstractValidator<GetNoteListQuery>
    {
        public GetNoteListQueryValidator()
        {
            RuleFor(nots => nots.Id).NotEqual(Guid.Empty);
            RuleFor(nots => nots.UserId).NotEqual(Guid.Empty);
        }
    }
}
