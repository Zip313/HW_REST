using System;
using System.Net.Http;

namespace WebClient
{
    public class CustomerCreateRequest
    {
        
        public CustomerCreateRequest()
        {
        }

        public CustomerCreateRequest(
            long id,
            string firstName,
            string lastName)
        {
            Id = id; //��������� �� ������� ��� ������ ���������� Id, ��� ��� � ������ �������� ��� ������ ������ ���������� ������ ���� �� ��� ����, ������ �� ������ ���������� �� � �������
            Firstname = firstName;
            Lastname = lastName;
        }

        public long Id { get; init; }
        public string Firstname { get; init; }

        public string Lastname { get; init; }
    }
}