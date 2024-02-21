// src/todo/todo.service.ts

import { Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Repository } from 'typeorm';
import { TodoEntity } from '../entity/todo.entity';
import { Todo } from 'src/todos/todo.model';

@Injectable()
export class TodoService {
  constructor(
    @InjectRepository(TodoEntity)
    private readonly todoRepository: Repository<TodoEntity>,
  ) {}

  async getAllTodos(): Promise<Todo[]> {
    return this.todoRepository.find();
  }

  async createTodo(todo: Todo): Promise<Todo> {
    return this.todoRepository.save(todo);
  }

  async updateTodo(id: number, todo: Todo): Promise<Todo> {
    await this.todoRepository.update(id, todo);
    return this.todoRepository.findOne({ where: { id } });
  }

  async deleteTodo(id: number): Promise<void> {
    await this.todoRepository.delete(id);
  }
}





// In summary, this constructor injects a repository instance 
// for the TodoEntity into the service class, allowing the service
//  to perform database operations (such as querying, saving, updating, 
//   and deleting TodoEntity instances) using methods provided by the 
//   repository. This is a common pattern in NestJS applications using 
//   TypeORM for database interaction.