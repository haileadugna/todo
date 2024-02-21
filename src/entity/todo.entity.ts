// src/todo/todo.entity.ts

import { Entity, PrimaryGeneratedColumn, Column } from 'typeorm';

@Entity('todo')
export class TodoEntity {
  @PrimaryGeneratedColumn()
  id: number;

  @Column({default: null})
  title: string;

  @Column({default: null})
  description: string;

  @Column({default: null})
  dueto: Date;
}
