import { Column, Entity, PrimaryGeneratedColumn } from 'typeorm';

@Entity({ name: 'AbpUsers' })
export class AbpUsers {
  @PrimaryGeneratedColumn('increment', { name: 'Id' })
  id: number;

  @Column({ name: 'AccessFailedCount', nullable: false })
  accessFailedCount: number;

  @Column({ name: 'AuthenticationSource', length: 64, nullable: true })
  authenticationSource?: string;

  @Column({ name: 'ConcurrencyStamp', length: 128, nullable: true })
  concurrencyStamp?: string;

  @Column({ name: 'CreationTime', nullable: false })
  customData: Date;

  @Column({ name: 'CreatorUserId', nullable: true })
  creatorUserId?: number;

  @Column({ name: 'DeleterUserId', nullable: true })
  deleterUserId?: number;

  @Column({ name: 'DeletionTime', nullable: true })
  deletionTime?: Date;

  @Column({ name: 'EmailAddress', length: 256, nullable: false })
  emailAddress: string;

  @Column({ name: 'EmailConfirmationCode', length: 328, nullable: true })
  emailConfirmationCode: string;

  @Column({ name: 'IsActive', nullable: false })
  isActive: boolean;

  @Column({ name: 'IsDeleted', nullable: false })
  isDeleted: boolean;

  @Column({ name: 'IsEmailConfirmed', nullable: false })
  isEmailConfirmed: boolean;

  @Column({ name: 'IsLockoutEnabled', nullable: false })
  isLockoutEnabled: boolean;

  @Column({ name: 'IsPhoneNumberConfirmed', nullable: false })
  isPhoneNumberConfirmed: boolean;

  @Column({ name: 'IsTwoFactorEnabled', nullable: false })
  isTwoFactorEnabled: boolean;

  @Column({ name: 'LastModificationTime', nullable: true })
  lastModificationTime?: Date;

  @Column({ name: 'LastModifierUserId', nullable: true })
  lastModifierUserId?: number;

  @Column({ name: 'LockoutEndDateUtc', nullable: true })
  lockoutEndDateUtc?: Date;

  @Column({ name: 'Name', length: 64, nullable: false })
  name: string;

  @Column({ name: 'NormalizedEmailAddress', length: 256, nullable: false })
  normalizedEmailAddress: string;

  @Column({ name: 'NormalizedUserName', length: 256, nullable: false })
  normalizedUserName: string;

  @Column({ name: 'Password', length: 128, nullable: false })
  password: string;

  @Column({ name: 'PasswordResetCode', length: 328, nullable: true })
  passwordResetCode?: string;

  @Column({ name: 'PhoneNumber', length: 32, nullable: false })
  phoneNumber: string;

  @Column({ name: 'SecurityStamp', length: 128, nullable: true })
  securityStamp?: string;

  @Column({ name: 'Surname', length: 64, nullable: false })
  surname: string;

  @Column({ name: 'TenantId', nullable: true })
  tenantId?: number;

  @Column({ name: 'UserName', length: 256, nullable: false })
  userName?: string;
}
