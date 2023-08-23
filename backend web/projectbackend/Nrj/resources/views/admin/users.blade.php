@extends('layouts.app')

@section('content')
<h1>Gebruikersbeheer</h1>

<table>
    <thead>
        <tr>
            <th>Naam</th>
            <th>Email</th>
            <th>Acties</th>
        </tr>
    </thead>
    <tbody>
        @foreach ($users as $user)
            <tr>
                <td>{{ $user->name }}</td>
                <td>{{ $user->email }}</td>
                <td>
                    <a href="{{ route('admin.users.show', $user->id) }}">Bekijk</a>
                    @if ($user->is_admin)
                        <form id="demote-form-{{ $user->id }}" action="{{ route('admin.users.demote', $user->id) }}" method="POST">
                            @csrf
                            @method('DELETE')
                            <input type="hidden" name="_method" value="POST">
                            <button type="submit">Beeindig admin</button>
                        </form>
                    @else
                        <form id="promote-form-{{ $user->id }}" action="{{ route('admin.users.promote', $user->id) }}" method="POST">
                            @csrf
                            <button type="submit">Bevorder tot admin</button>
                        </form>
                    @endif
                </td>
            </tr>
        @endforeach
    </tbody>
</table>
@endsection
