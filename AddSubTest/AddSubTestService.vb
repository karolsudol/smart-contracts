Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts.ContractHandlers
Imports Nethereum.Contracts
Imports System.Threading
Imports SmartContracts.Contracts.AddSubTest.ContractDefinition
Namespace SmartContracts.Contracts.AddSubTest


    Public Partial Class AddSubTestService
    
    
        Public Shared Function DeployContractAndWaitForReceiptAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal addSubTestDeployment As AddSubTestDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return web3.Eth.GetContractDeploymentHandler(Of AddSubTestDeployment)().SendRequestAndWaitForReceiptAsync(addSubTestDeployment, cancellationTokenSource)
        
        End Function
         Public Shared Function DeployContractAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal addSubTestDeployment As AddSubTestDeployment) As Task(Of String)
        
            Return web3.Eth.GetContractDeploymentHandler(Of AddSubTestDeployment)().SendRequestAsync(addSubTestDeployment)
        
        End Function
        Public Shared Async Function DeployContractAndGetServiceAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal addSubTestDeployment As AddSubTestDeployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of AddSubTestService)
        
            Dim receipt = Await DeployContractAndWaitForReceiptAsync(web3, addSubTestDeployment, cancellationTokenSource)
            Return New AddSubTestService(web3, receipt.ContractAddress)
        
        End Function
    
        Protected Property Web3 As Nethereum.Web3.Web3
        
        Public Property ContractHandler As ContractHandler
        
        Public Sub New(ByVal web3 As Nethereum.Web3.Web3, ByVal contractAddress As String)
            Web3 = web3
            ContractHandler = web3.Eth.GetContractHandler(contractAddress)
        End Sub
    
        Public Function IS_TESTQueryAsync(ByVal iS_TESTFunction As IS_TESTFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            Return ContractHandler.QueryAsync(Of IS_TESTFunction, Boolean)(iS_TESTFunction, blockParameter)
        
        End Function

        
        Public Function IS_TESTQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of Boolean)
        
            return ContractHandler.QueryAsync(Of IS_TESTFunction, Boolean)(Nothing, blockParameter)
        
        End Function



        Public Function FailedRequestAsync(ByVal failedFunction As FailedFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of FailedFunction)(failedFunction)
        
        End Function

        Public Function FailedRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of FailedFunction)
        
        End Function

        Public Function FailedRequestAndWaitForReceiptAsync(ByVal failedFunction As FailedFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of FailedFunction)(failedFunction, cancellationToken)
        
        End Function

        Public Function FailedRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of FailedFunction)(Nothing, cancellationToken)
        
        End Function
        Public Function SetUpRequestAsync(ByVal setUpFunction As SetUpFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SetUpFunction)(setUpFunction)
        
        End Function

        Public Function SetUpRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SetUpFunction)
        
        End Function

        Public Function SetUpRequestAndWaitForReceiptAsync(ByVal setUpFunction As SetUpFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetUpFunction)(setUpFunction, cancellationToken)
        
        End Function

        Public Function SetUpRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetUpFunction)(Nothing, cancellationToken)
        
        End Function
        Public Function TestFail_AddRequestAsync(ByVal testFail_AddFunction As TestFail_AddFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of TestFail_AddFunction)(testFail_AddFunction)
        
        End Function

        Public Function TestFail_AddRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of TestFail_AddFunction)
        
        End Function

        Public Function TestFail_AddRequestAndWaitForReceiptAsync(ByVal testFail_AddFunction As TestFail_AddFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TestFail_AddFunction)(testFail_AddFunction, cancellationToken)
        
        End Function

        Public Function TestFail_AddRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TestFail_AddFunction)(Nothing, cancellationToken)
        
        End Function
        Public Function TestFail_SubRequestAsync(ByVal testFail_SubFunction As TestFail_SubFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of TestFail_SubFunction)(testFail_SubFunction)
        
        End Function

        Public Function TestFail_SubRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of TestFail_SubFunction)
        
        End Function

        Public Function TestFail_SubRequestAndWaitForReceiptAsync(ByVal testFail_SubFunction As TestFail_SubFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TestFail_SubFunction)(testFail_SubFunction, cancellationToken)
        
        End Function

        Public Function TestFail_SubRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TestFail_SubFunction)(Nothing, cancellationToken)
        
        End Function
        Public Function TestFuzz_AddRequestAsync(ByVal testFuzz_AddFunction As TestFuzz_AddFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of TestFuzz_AddFunction)(testFuzz_AddFunction)
        
        End Function

        Public Function TestFuzz_AddRequestAndWaitForReceiptAsync(ByVal testFuzz_AddFunction As TestFuzz_AddFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TestFuzz_AddFunction)(testFuzz_AddFunction, cancellationToken)
        
        End Function

        
        Public Function TestFuzz_AddRequestAsync(ByVal [x] As BigInteger, ByVal [y] As BigInteger) As Task(Of String)
        
            Dim testFuzz_AddFunction = New TestFuzz_AddFunction()
                testFuzz_AddFunction.X = [x]
                testFuzz_AddFunction.Y = [y]
            
            Return ContractHandler.SendRequestAsync(Of TestFuzz_AddFunction)(testFuzz_AddFunction)
        
        End Function

        
        Public Function TestFuzz_AddRequestAndWaitForReceiptAsync(ByVal [x] As BigInteger, ByVal [y] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim testFuzz_AddFunction = New TestFuzz_AddFunction()
                testFuzz_AddFunction.X = [x]
                testFuzz_AddFunction.Y = [y]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TestFuzz_AddFunction)(testFuzz_AddFunction, cancellationToken)
        
        End Function
        Public Function TestFuzz_SubRequestAsync(ByVal testFuzz_SubFunction As TestFuzz_SubFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of TestFuzz_SubFunction)(testFuzz_SubFunction)
        
        End Function

        Public Function TestFuzz_SubRequestAndWaitForReceiptAsync(ByVal testFuzz_SubFunction As TestFuzz_SubFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TestFuzz_SubFunction)(testFuzz_SubFunction, cancellationToken)
        
        End Function

        
        Public Function TestFuzz_SubRequestAsync(ByVal [x] As BigInteger, ByVal [y] As BigInteger) As Task(Of String)
        
            Dim testFuzz_SubFunction = New TestFuzz_SubFunction()
                testFuzz_SubFunction.X = [x]
                testFuzz_SubFunction.Y = [y]
            
            Return ContractHandler.SendRequestAsync(Of TestFuzz_SubFunction)(testFuzz_SubFunction)
        
        End Function

        
        Public Function TestFuzz_SubRequestAndWaitForReceiptAsync(ByVal [x] As BigInteger, ByVal [y] As BigInteger, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim testFuzz_SubFunction = New TestFuzz_SubFunction()
                testFuzz_SubFunction.X = [x]
                testFuzz_SubFunction.Y = [y]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of TestFuzz_SubFunction)(testFuzz_SubFunction, cancellationToken)
        
        End Function
        Public Function Test_AddRequestAsync(ByVal test_AddFunction As Test_AddFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of Test_AddFunction)(test_AddFunction)
        
        End Function

        Public Function Test_AddRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of Test_AddFunction)
        
        End Function

        Public Function Test_AddRequestAndWaitForReceiptAsync(ByVal test_AddFunction As Test_AddFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of Test_AddFunction)(test_AddFunction, cancellationToken)
        
        End Function

        Public Function Test_AddRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of Test_AddFunction)(Nothing, cancellationToken)
        
        End Function
        Public Function Test_SubRequestAsync(ByVal test_SubFunction As Test_SubFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of Test_SubFunction)(test_SubFunction)
        
        End Function

        Public Function Test_SubRequestAsync() As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of Test_SubFunction)
        
        End Function

        Public Function Test_SubRequestAndWaitForReceiptAsync(ByVal test_SubFunction As Test_SubFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of Test_SubFunction)(test_SubFunction, cancellationToken)
        
        End Function

        Public Function Test_SubRequestAndWaitForReceiptAsync(ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of Test_SubFunction)(Nothing, cancellationToken)
        
        End Function
    
    End Class

End Namespace
