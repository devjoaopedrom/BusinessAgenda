# Regras de Negócio - BusinessAgenda

## Usuário
- Cada usuário pode ser do tipo:
  - `Gerente`
  - `Supervisor`
- Um usuário **não pode ser dos dois tipos ao mesmo tempo**.

## Agenda
- Cada gerente possui **apenas uma agenda** (relação 1:1).
- A agenda pertence exclusivamente ao gerente.

## Reunião
- A duração de uma reunião é de **1 hora fixa no minimo**.
- Não pode haver mais de uma reunião no mesmo horário.
- Horários disponíveis para agendamento:
  - Status `Disponível`
  - Status `Cancelado`
- Horários com status `Ocupado` estão **bloqueados** para novos agendamentos.

## Supervisor
- Pode consultar e editar agendas de todos os gerentes.

