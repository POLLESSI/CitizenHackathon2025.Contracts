using CitizenHackathon2025.Contracts.DTOs;
using System.Threading.Tasks;

namespace CitizenHackathon2025.Contracts.Hubs
{
    public interface IGptClient
    {
        Task ReceiveGptResponseStarted(GptResponseStartedDto dto);
        Task ReceiveGptResponseChunk(GptResponseChunkDto dto);
        Task ReceiveGptResponseStatus(GptResponseStatusDto dto);

        // Optional but very useful for resynchronizing the final state
        Task ReceiveGptResponseCompleted(GptInteractionCompletedDto dto);
    }
}



























































































// Copyrigtht (c) 2025 Citizen Hackathon https://github.com/POLLESSI/Citizenhackathon2025.API. All rights reserved.