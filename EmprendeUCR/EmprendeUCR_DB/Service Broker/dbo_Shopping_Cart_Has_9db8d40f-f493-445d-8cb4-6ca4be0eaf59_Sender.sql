CREATE QUEUE [dbo].[dbo_Shopping_Cart_Has_9db8d40f-f493-445d-8cb4-6ca4be0eaf59_Sender]
    WITH POISON_MESSAGE_HANDLING(STATUS = OFF), ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[dbo_Shopping_Cart_Has_9db8d40f-f493-445d-8cb4-6ca4be0eaf59_QueueActivationSender], MAX_QUEUE_READERS = 1, EXECUTE AS N'EmprendeAdmin');



