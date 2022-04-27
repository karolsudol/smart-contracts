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
Imports SmartContracts.Contracts.D1.ContractDefinition
Namespace SmartContracts.Contracts.D1


    Public Partial Class D1Service
    
    
        Public Shared Function DeployContractAndWaitForReceiptAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal d1Deployment As D1Deployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return web3.Eth.GetContractDeploymentHandler(Of D1Deployment)().SendRequestAndWaitForReceiptAsync(d1Deployment, cancellationTokenSource)
        
        End Function
         Public Shared Function DeployContractAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal d1Deployment As D1Deployment) As Task(Of String)
        
            Return web3.Eth.GetContractDeploymentHandler(Of D1Deployment)().SendRequestAsync(d1Deployment)
        
        End Function
        Public Shared Async Function DeployContractAndGetServiceAsync(ByVal web3 As Nethereum.Web3.Web3, ByVal d1Deployment As D1Deployment, ByVal Optional cancellationTokenSource As CancellationTokenSource = Nothing) As Task(Of D1Service)
        
            Dim receipt = Await DeployContractAndWaitForReceiptAsync(web3, d1Deployment, cancellationTokenSource)
            Return New D1Service(web3, receipt.ContractAddress)
        
        End Function
    
        Protected Property Web3 As Nethereum.Web3.Web3
        
        Public Property ContractHandler As ContractHandler
        
        Public Sub New(ByVal web3 As Nethereum.Web3.Web3, ByVal contractAddress As String)
            Web3 = web3
            ContractHandler = web3.Eth.GetContractHandler(contractAddress)
        End Sub
    
        Public Function OwnerQueryAsync(ByVal ownerFunction As OwnerFunction, ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            Return ContractHandler.QueryAsync(Of OwnerFunction, String)(ownerFunction, blockParameter)
        
        End Function

        
        Public Function OwnerQueryAsync(ByVal Optional blockParameter As BlockParameter = Nothing) As Task(Of String)
        
            return ContractHandler.QueryAsync(Of OwnerFunction, String)(Nothing, blockParameter)
        
        End Function



        Public Function SetownerRequestAsync(ByVal setownerFunction As SetownerFunction) As Task(Of String)
                    
            Return ContractHandler.SendRequestAsync(Of SetownerFunction)(setownerFunction)
        
        End Function

        Public Function SetownerRequestAndWaitForReceiptAsync(ByVal setownerFunction As SetownerFunction, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetownerFunction)(setownerFunction, cancellationToken)
        
        End Function

        
        Public Function SetownerRequestAsync(ByVal [owner] As String) As Task(Of String)
        
            Dim setownerFunction = New SetownerFunction()
                setownerFunction.Owner = [owner]
            
            Return ContractHandler.SendRequestAsync(Of SetownerFunction)(setownerFunction)
        
        End Function

        
        Public Function SetownerRequestAndWaitForReceiptAsync(ByVal [owner] As String, ByVal Optional cancellationToken As CancellationTokenSource = Nothing) As Task(Of TransactionReceipt)
        
            Dim setownerFunction = New SetownerFunction()
                setownerFunction.Owner = [owner]
            
            Return ContractHandler.SendRequestAndWaitForReceiptAsync(Of SetownerFunction)(setownerFunction, cancellationToken)
        
        End Function
    
    End Class

End Namespace
