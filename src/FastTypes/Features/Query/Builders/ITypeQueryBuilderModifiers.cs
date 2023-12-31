﻿using System;

namespace FastTypes.Features.Query
{
    public interface ITypeQueryBuilderModifiers : ITypeQueryBuilderPreparation
    {
        ITypeQueryBuilderModifiers WithCriteria(ITypeQueryCriteria criteria);

        ITypeQueryBuilderModifiers NotPublic();

        ITypeQueryBuilderModifiers WithPropertyOfType<T>();
        ITypeQueryBuilderModifiers WithPropertyOfType(Type t);

        ITypeQueryBuilderModifiers WithMethodOfType<T>();
        ITypeQueryBuilderModifiers WithMethodOfType(Type t);

        ITypeQueryBuilderModifiers WithAttribute<T>() where T : Attribute;
        ITypeQueryBuilderModifiers WithAttribute(Type t);

        ITypeQueryBuilderModifiers AssignableTo<T>();
        ITypeQueryBuilderModifiers AssignableTo(Type t);
    }
}