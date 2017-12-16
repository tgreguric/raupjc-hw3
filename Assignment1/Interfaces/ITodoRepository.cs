﻿using System;
using System.Collections.Generic;
using Assignment1.Models;

namespace Assignment1.Interfaces
{
	public interface ITodoRepository
	{
		TodoItem Get(Guid todoId, Guid userId);
		void Add(TodoItem todoItem);
		bool Remove(Guid todoId, Guid userId);

		void Update(TodoItem todoItem, Guid userId);
		bool MarkAsCompleted(Guid todoId, Guid userId);
		bool RemoveFromCompleted(Guid todoId, Guid userId);

		List<TodoItem> GetAll(Guid userId);
		List<TodoItem> GetActive(Guid userId);
		List<TodoItem> GetCompleted(Guid userId);
		List<TodoItem> GetFiltered(Func<TodoItem, bool> filterFunction, Guid userId);
		TodoItemLabel AddLabel(TodoItemLabel todoItemLabel);

	}
}