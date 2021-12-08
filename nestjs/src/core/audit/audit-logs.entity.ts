import { Column, Entity, PrimaryGeneratedColumn } from 'typeorm';

@Entity({ name: 'AbpAuditLogs' })
export class AuditLogs {
  @PrimaryGeneratedColumn('increment', { name: 'Id' })
  id: number;

  @Column({ name: 'BrowserInfo', length: 512, nullable: true })
  browserInfo?: string;

  @Column({ name: 'ClientIPAddress', length: 64, nullable: true })
  clientIPAddress?: string;

  @Column({ name: 'ClientName', length: 128, nullable: true })
  clientName?: string;

  @Column({ name: 'CustomData', length: 2000, nullable: true })
  customData?: string;

  @Column({ name: 'Exception', length: 2000, nullable: true })
  exception?: string;

  @Column({ name: 'ExecutionDuration', nullable: false })
  executionDuration: number;

  @Column({ name: 'ExecutionTime', nullable: false })
  executionTime: Date;

  @Column({ name: 'ImpersonatorTenantId', nullable: false })
  impersonatorTenantId: number;

  @Column({ name: 'ImpersonatorUserId', nullable: false })
  impersonatorUserId: number;

  @Column({ name: 'MethodName', length: 256, nullable: true })
  methodName?: string;

  @Column({ name: 'Parameters', length: 1024, nullable: true })
  parameters?: string;

  @Column({ name: 'ServiceName', length: 256, nullable: true })
  serviceName?: string;

  @Column({ name: 'TenantId', nullable: true })
  tenantId?: number;

  @Column({ name: 'UserId', nullable: true })
  userId?: number;

  @Column({ name: 'ReturnValue', nullable: true })
  returnValue?: string;

  @Column({ name: 'ExceptionMessage', length: 1024, nullable: true })
  exceptionMessage?: string;
}
