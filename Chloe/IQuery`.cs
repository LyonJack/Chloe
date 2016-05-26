﻿using Chloe.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Chloe
{
    public interface IQuery<T> //:   IEnumerable<T>, IEnumerable
    {
        IQuery<T> AsTracking();
        IEnumerable<T> AsEnumerable();
        IQuery<TResult> Select<TResult>(Expression<Func<T, TResult>> selector);

        IQuery<T> Where(Expression<Func<T, bool>> predicate);
        IOrderedQuery<T> OrderBy<K>(Expression<Func<T, K>> predicate);
        IOrderedQuery<T> OrderByDesc<K>(Expression<Func<T, K>> predicate);
        IQuery<T> Skip(int count);
        IQuery<T> Take(int count);

        IGroupingQuery<T> GroupBy<K>(Expression<Func<T, K>> predicate);

        IJoiningQuery<T, TSource> InnerJoin<TSource>(IQuery<TSource> q, Expression<Func<T, TSource, bool>> on);
        IJoiningQuery<T, TSource> LeftJoin<TSource>(IQuery<TSource> q, Expression<Func<T, TSource, bool>> on);
        IJoiningQuery<T, TSource> RightJoin<TSource>(IQuery<TSource> q, Expression<Func<T, TSource, bool>> on);
        IJoiningQuery<T, TSource> FullJoin<TSource>(IQuery<TSource> q, Expression<Func<T, TSource, bool>> on);

        T First();
        T First(Expression<Func<T, bool>> predicate);
        T FirstOrDefault();
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        List<T> ToList();

        bool Any();
        bool Any(Expression<Func<T, bool>> predicate);

        int Count();
        long LongCount();

        int Sum(Expression<Func<T, int>> selector);
        int? Sum(Expression<Func<T, int?>> selector);
        long Sum(Expression<Func<T, long>> selector);
        long? Sum(Expression<Func<T, long?>> selector);
        decimal Sum(Expression<Func<T, decimal>> selector);
        decimal? Sum(Expression<Func<T, decimal?>> selector);
        double Sum(Expression<Func<T, double>> selector);
        double? Sum(Expression<Func<T, double?>> selector);
        float Sum(Expression<Func<T, float>> selector);
        float? Sum(Expression<Func<T, float?>> selector);

        int Max(Expression<Func<T, int>> selector);
        int? Max(Expression<Func<T, int?>> selector);
        long Max(Expression<Func<T, long>> selector);
        long? Max(Expression<Func<T, long?>> selector);
        decimal Max(Expression<Func<T, decimal>> selector);
        decimal? Max(Expression<Func<T, decimal?>> selector);
        double Max(Expression<Func<T, double>> selector);
        double? Max(Expression<Func<T, double?>> selector);
        float Max(Expression<Func<T, float>> selector);
        float? Max(Expression<Func<T, float?>> selector);

        int Min(Expression<Func<T, int>> selector);
        int? Min(Expression<Func<T, int?>> selector);
        long Min(Expression<Func<T, long>> selector);
        long? Min(Expression<Func<T, long?>> selector);
        decimal Min(Expression<Func<T, decimal>> selector);
        decimal? Min(Expression<Func<T, decimal?>> selector);
        double Min(Expression<Func<T, double>> selector);
        double? Min(Expression<Func<T, double?>> selector);
        float Min(Expression<Func<T, float>> selector);
        float? Min(Expression<Func<T, float?>> selector);

        double Average(Expression<Func<T, int>> selector);
        double? Average(Expression<Func<T, int?>> selector);
        double Average(Expression<Func<T, long>> selector);
        double? Average(Expression<Func<T, long?>> selector);
        decimal Average(Expression<Func<T, decimal>> selector);
        decimal? Average(Expression<Func<T, decimal?>> selector);
        double Average(Expression<Func<T, double>> selector);
        double? Average(Expression<Func<T, double?>> selector);
        float Average(Expression<Func<T, float>> selector);
        float? Average(Expression<Func<T, float?>> selector);
    }
}