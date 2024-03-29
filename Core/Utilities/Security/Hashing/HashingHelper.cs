﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
        public class HashingHelper
        {
            public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
            {
                using (var hmac = new HMACSHA512())
                {
                    passwordSalt = hmac.Key;
                    passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                }
            }
        //passwordhash i doğrulama demek
        //sisteme tekrardan girmeye çalışıyor.şifre girerek. Girdiğiniz şifreyi kontrol ediyo
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
            {

                using (var hmac = new HMACSHA512(passwordSalt))
                {
                    var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                    for (int i = 0; i < computedHash.Length; i++)
                    {
                        if (computedHash[i] != passwordHash[i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
  