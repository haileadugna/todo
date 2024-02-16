// src/todo/todo.controller.ts

import { Controller, Get, Post, Put, Delete, Body, Param } from '@nestjs/common';
import { TodoService } from './todo.service';
import { Todo } from '../todo.entity';

@Controller('todos')
export class TodoController {
  constructor(private readonly todoService: TodoService) {}

  @Get()
  getAllTodos() {
    return this.todoService.getAllTodos();
  }

  @Post()
  createTodo(@Body() todo: Todo) {
    return this.todoService.createTodo(todo);
  }

  @Put(':id')
  updateTodo(@Param('id') id: number, @Body() todo: Todo) {
    return this.todoService.updateTodo(id, todo);
  }

  @Delete(':id')
  deleteTodo(@Param('id') id: number) {
    return this.todoService.deleteTodo(id);
  }
}
