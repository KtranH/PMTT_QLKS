<?php

namespace App\Http\Middleware;

use Closure;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\RateLimiter;
use Symfony\Component\HttpFoundation\Response;

class CheckResendCodeAuthEmail
{
    /**
     * Handle an incoming request.
     *
     * @param  \Closure(\Illuminate\Http\Request): (\Symfony\Component\HttpFoundation\Response)  $next
     */
    public function handle($request, Closure $next, $maxAttempts = 2, $decayMinutes = 1)
    {
        $key = $this->resolveRequestSignature($request);

        $errors = [];

        if (RateLimiter::tooManyAttempts($key, $maxAttempts)) 
        {
            $errors["ManyTime"] = 'Bạn chỉ được gửi yêu cầu mỗi 5 phút';
            return redirect()->back()->withErrors($errors);
        }

        RateLimiter::hit($key, $decayMinutes * 60);

        return $next($request);
    }
    protected function resolveRequestSignature($request)
    {
        return sha1(
            $request->ip()
        );
    }
}
